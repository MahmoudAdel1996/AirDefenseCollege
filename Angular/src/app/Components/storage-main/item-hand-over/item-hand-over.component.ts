import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Branch } from 'src/app/Models/Classes/Branch';
import { Category } from 'src/app/Models/Classes/Category';
import { Daraga } from 'src/app/Models/Classes/Daraga';
import { Items } from 'src/app/Models/Classes/Items';
import { ItemTransaction } from 'src/app/Models/Classes/ItemTransaction';
import { ApiClientService } from 'src/app/Services/api-client.service';

@Component({
  selector: 'app-item-hand-over',
  templateUrl: './item-hand-over.component.html',
  styleUrls: ['./item-hand-over.component.scss']
})
export class ItemHandOverComponent implements OnInit {
  currentForm!: FormGroup;
  daragat!: Daraga[];
  branches!: Branch[];
  items!: Items[];
  categories!: Category[];
  showForms = false;
  allQuantity= 0;
  showItemOnly = false;
  isLoading = false;
  constructor(private client: ApiClientService, public formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.currentForm = this.formBuilder.group({
      category: ['', [Validators.required]],
      item: ['', [Validators.required, Validators.maxLength(100)]],
      quantity: ['1', [Validators.required, Validators.min(1)]],
      paid: ['0', [Validators.min(0), Validators.required]],
      daraga1: ['', [Validators.required]],
      name1: ['', [Validators.required, Validators.maxLength(100)]],
      branch: ['', [Validators.required]],
      daraga2: ['', [Validators.required]],
      name2: ['', [Validators.required, Validators.maxLength(100)]],

    });
    this.client.GetAllDaragat().subscribe(data =>{
      this.daragat = data;
    })
    this.client.GetAllBranches().subscribe(data =>{
      this.branches = data;
    })
    this.client.GetCategoryWithQuantity().subscribe(data => {
      this.categories = data.filter(x => x.quantity > 0);
    })
  
  }

  get formFields() {
    return this.currentForm.controls;
  }
  categorySelected(categoryId: number){
    this.orderQuantity = 0;
    this.showItemOnly = false;
    this.showForms = false;
    if(categoryId < 1) return;
    this.client.GetItemsByCategoryId(categoryId).subscribe(data =>{
      this.showItemOnly = true;
      this.items = data.filter(x=>x.quantity > 0);
    })
  }
  itemSelected(itemId: number){
    this.showForms = false;
    if(itemId < 1) return;
    this.reset();
    const item = this.items?.find(x=> x.id == itemId);
    this.orderPrice = 0;
    this.orderQuantity = Number(item?.quantity);
    this.orderReminderQuantity = Number(item?.quantity);
    this.showForms = true;

    this.currentForm.controls["quantity"].setValidators([Validators.required, Validators.max(this.orderQuantity), Validators.min(0)]);
    this.currentForm.controls["quantity"].updateValueAndValidity();
  }
  orderPrice?: number;
  orderQuantity?: number;
  orderReminderQuantity?: number;
  changeQuantity(quantity: number) {
    const selectedItemId= Number(this.formFields.item.value)
    const item = this.items?.find(x=> x.id == selectedItemId)
    this.orderPrice = Number(item?.price) * quantity;
    this.orderQuantity = Number(item?.quantity);
    this.orderReminderQuantity = Number(item?.quantity) - Math.abs(quantity);
  }
  addItem() {
    this.isLoading = true;
    let itemTransaction: ItemTransaction =  {
        id: 0,
        paid: Number(this.formFields.paid.value),
        itemsId: Number(this.formFields.item.value),
        quantity: Number(this.formFields.quantity.value),
        reciverPerson: {daragaId:Number(this.formFields.daraga1.value),branchId: Number(this.formFields.branch.value), name: this.formFields.name1.value},
        handOverPerson:{daragaId:Number(this.formFields.daraga2.value),branchId: 15, name: this.formFields.name2.value},
    };
    this.client.AddItemTransaction(itemTransaction).subscribe(x=> {
      alert("تم التسليم");
      this.ngOnInit();
      this.isLoading = false;
    },
    error => {
      alert("فشلت العملية");
      this.isLoading = false;
    }
    );
  }
  resetAll() {
    this.formFields.category.reset();
    this.formFields.item.reset();
    this.showForms = false;
    this.allQuantity= 0;
    this.showItemOnly = false;
    this.reset();
  }
  reset() {
    this.formFields.quantity.reset();
    this.formFields.paid.reset();
    this.formFields.daraga1.reset();
    this.formFields.name1.reset();
    this.formFields.branch.reset();
    this.formFields.daraga2.reset();
    this.formFields.name2.reset();
    this.formFields.branch.reset();
  }
}
