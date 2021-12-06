import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Transaction } from 'src/app/Models/Classes/Transaction';
import { ApiClientService } from 'src/app/Services/api-client.service';

@Component({
  selector: 'app-note-dialog',
  templateUrl: './note-dialog.component.html',
  styleUrls: ['./note-dialog.component.scss']
})
export class NoteDialogComponent implements OnInit {

  constructor( public formBulder:FormBuilder, private client: ApiClientService, public dialog: MatDialog, @Inject(MAT_DIALOG_DATA) public data: Transaction) { }

  currentForm!: FormGroup;

  ngOnInit(): void {
    this.currentForm = this.formBulder.group({
      notes: [this.data.notes, [Validators.required]],
    })
  }

  get formFields() {
    return this.currentForm.controls;
  }

  editNote() {
    this.data.notes = String(this.formFields.notes.value)?.trim();
    if(!this.currentForm.invalid)
      this.client.UpdateTransaction(this.data).subscribe(_ => {
        this.dialog.closeAll();
      });
  }

}
