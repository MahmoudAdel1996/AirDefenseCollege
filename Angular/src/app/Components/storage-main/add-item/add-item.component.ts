import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatButtonToggleChange } from '@angular/material/button-toggle';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { Category } from 'src/app/Models/Classes/Category';
import { Item } from 'src/app/Models/Classes/Item';
import { Items } from 'src/app/Models/Classes/Items';
import { ApiClientService } from 'src/app/Services/api-client.service';

@Component({
  selector: 'app-add-item',
  templateUrl: './add-item.component.html',
  styleUrls: ['./add-item.component.scss']
})
export class AddItemComponent implements OnInit {
  currentForm!: FormGroup;
  items!:Items[];
  categories!: Category[];
  showForms = false;
  allQuantity= 0;
  showItemOnly = false;
  newItem = false;
  isLoading = false;
  constructor(private client: ApiClientService, public formBuilder: FormBuilder) { }
  
  ngOnInit(): void {
    this.currentForm = this.formBuilder.group({
      category: ['', [Validators.required]],
      name: ['', [Validators.maxLength(100)]],
      item: ['', [Validators.maxLength(100)]],
      price: ['0', [Validators.required, Validators.min(0)]],
      newItem: [this.newItem, []],
      quantity: ['1', [Validators.required, Validators.min(1)]],
    });
    this.client.GetAllCategory().subscribe(data => {
      this.categories = data;
    })
  
  }

  get formFields() {
    return this.currentForm.controls;
  }

  categorySelected(categoryId: number){
    this.showItemOnly = false;
    this.formFields.newItem.reset();
    this.newItem = false;
    this.showForms = false;
    if(categoryId < 1) return;
    this.client.GetItemsByCategoryId(categoryId).subscribe(data =>{
      this.showItemOnly = true;
      this.items = data;
    })
  }
  toggleButtonChange(value: MatSlideToggleChange) {
    this.newItem = value.checked;
    if (value.checked == true){
      this.showForms = true;
      this.reset();
      this.currentForm.controls["name"].setValidators([Validators.required, Validators.maxLength(100)]);
      this.currentForm.controls["name"].updateValueAndValidity();
      this.currentForm.controls["item"].setValidators([]);
      this.currentForm.controls["item"].updateValueAndValidity();
    }else{
      this.currentForm.controls["item"].setValidators([Validators.required, Validators.maxLength(100)]);
      this.currentForm.controls["item"].updateValueAndValidity();
      this.currentForm.controls["name"].setValidators([]);
      this.currentForm.controls["name"].updateValueAndValidity();
    }
  }
  itemSelected(itemId: number){
    this.showForms = false;
    if(itemId < 1) return;
    const currentPrice = this.items.find(x=>x.id == itemId)?.price;
    this.reset();
    this.formFields.price.setValue(currentPrice);
    this.showForms = true;
  }
  addItem() {
    this.isLoading = true;
    let item: Items = {
      id: Number(this.formFields.item.value),
      sameTypeItems: [],
      categoryId: Number(this.formFields.category.value),
      name: this.formFields.name.value,
      price: this.formFields.price.value,
      quantity: this.formFields.quantity.value
    }
    if(this.formFields.newItem.value == true){
      this.client.AddItems(item).subscribe(_ => {
        this.isLoading = false;
        alert("تم إضافة المنتج");
      },
      error => {
        this.isLoading = false;
        alert("فشلت العملية");
      }
      );
    }else {
      this.client.UpdateItemsWithoutName(item).subscribe(_ => {
        this.isLoading = false;
        alert("تم إضافة المنتج");
      },
      error => {
        this.isLoading = false;
        alert("فشلت العملية");
      }
      );
    }
  }
  reset() {
    this.formFields.name.reset();
    if(this.formFields.newItem.value)
      this.formFields.item.reset();
    this.formFields.quantity.reset();
    this.formFields.price.reset();
  }
  resetAll() {
    this.showForms = false;
    this.allQuantity= 0;
    this.showItemOnly = false;
    this.newItem = false;
    this.formFields.category.reset();
    this.formFields.newItem.reset();
    this.formFields.item.reset();
    this.formFields.name.reset();
    this.formFields.price.reset();
    this.formFields.quantity.reset();
  
  }
}
