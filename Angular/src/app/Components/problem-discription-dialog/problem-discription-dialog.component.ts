import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Transaction } from 'src/app/Models/Classes/Transaction';
import { ApiClientService } from 'src/app/Services/api-client.service';

@Component({
  selector: 'app-problem-discription-dialog',
  templateUrl: './problem-discription-dialog.component.html',
  styleUrls: ['./problem-discription-dialog.component.scss']
})
export class ProblemDiscriptionDialogComponent implements OnInit {

  constructor( public formBulder:FormBuilder, private client: ApiClientService, public dialog: MatDialog, @Inject(MAT_DIALOG_DATA) public data: Transaction) { }

  currentForm!: FormGroup;

  ngOnInit(): void {
    this.currentForm = this.formBulder.group({
      problem: [this.data.problemDeescription, [Validators.required]],
    })
  }

  get formFields() {
    return this.currentForm.controls;
  }

  editProblemDescription() {
    this.data.problemDeescription = String(this.formFields.problem.value)?.trim();
    if(!this.currentForm.invalid)
      this.client.UpdateTransaction(this.data).subscribe(_ => {
        this.dialog.closeAll();
      });
  }
}
