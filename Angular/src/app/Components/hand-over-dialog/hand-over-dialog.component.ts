import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Daraga } from 'src/app/Models/Classes/Daraga';
import { Transaction } from 'src/app/Models/Classes/Transaction';
import { ApiClientService } from 'src/app/Services/api-client.service';

@Component({
  selector: 'app-hand-over-dialog',
  templateUrl: './hand-over-dialog.component.html',
  styleUrls: ['./hand-over-dialog.component.scss']
})
export class HandOverDialogComponent implements OnInit {

  constructor( public formBulder:FormBuilder, private client: ApiClientService, public dialog: MatDialog, @Inject(MAT_DIALOG_DATA) public data: Transaction) { }
  daragat!: Daraga[];
  currentForm!: FormGroup;

  ngOnInit(): void {
    this.currentForm = this.formBulder.group({
      daraga3: ['', [Validators.required]],
      name3: ['', [Validators.required, Validators.maxLength(100)]],
    })
    this.client.GetAllDaragat().subscribe(data =>{
      this.daragat = data;
    });
  }
  get formFields() {
    return this.currentForm.controls;
  }
  handOver() {
    this.data.handOverToDaragaId = Number(this.formFields.daraga3.value);
    this.data.handOverToName = this.formFields.name3.value;
    if(!this.currentForm.invalid)
      this.client.UpdateTransactionHandOver(this.data).subscribe(_ => {
        this.dialog.closeAll();
      });
  }
}
