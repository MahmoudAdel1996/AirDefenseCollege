import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Category } from 'src/app/Models/Classes/Category';
import { ApiClientService } from 'src/app/Services/api-client.service';

@Component({
  selector: 'app-add-category-dialog',
  templateUrl: './add-category-dialog.component.html',
  styleUrls: ['./add-category-dialog.component.scss']
})
export class AddCategoryDialogComponent implements OnInit {

  constructor( public formBulder:FormBuilder, private client: ApiClientService, public dialog: MatDialog, @Inject(MAT_DIALOG_DATA) public data: Category[]) { }
  currentForm!: FormGroup;

  ngOnInit(): void {
    this.currentForm = this.formBulder.group({
      category: ['', [Validators.required, Validators.maxLength(100)]],
    })
  }
  get formFields() {
    return this.currentForm.controls;
  }
  AddCategory() {
    let exist = false;
    this.data.forEach(x => {
      if(x.name == this.formFields.category.value){
        alert("هذا الصنف تم إضافته من قبل");
        exist = true;
        return;
      }
    })
    if(!exist && !this.currentForm.invalid)
      this.client.AddCategory({name: this.formFields.category.value, quantity: 0}).subscribe(_ => {
        this.dialog.closeAll();
      },
      error => {
        alert("فشلت العملية");
      }
      );
  }
}
