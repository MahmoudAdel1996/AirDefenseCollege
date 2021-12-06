import { Directionality } from '@angular/cdk/bidi';
import { AfterViewInit, Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable, Subscription } from 'rxjs';
import { Branch } from 'src/app/Models/Classes/Branch';
import { Daraga } from 'src/app/Models/Classes/Daraga';
import { ApiClientService } from 'src/app/Services/api-client.service';
import {map, startWith} from 'rxjs/operators';
import { DeviceType } from 'src/app/Models/Classes/DeviceType';
import { Transaction } from 'src/app/Models/Classes/Transaction';

@Component({
  selector: 'app-add-transaction',
  templateUrl: './add-transaction.component.html',
  styleUrls: ['./add-transaction.component.scss']
})
export class AddTransactionComponent implements OnInit  {
  constructor(private client: ApiClientService, public formBuilder: FormBuilder) {  }
  options!: DeviceType[];
  filteredOptions!: Observable<DeviceType[]>;
  daragat!: Daraga[];
  branches!: Branch[];
  isLoading = false;

  currentForm!: FormGroup;


  get formFields() {
    return this.currentForm.controls;
  }

  ngOnInit(): void {
    this.client.GetAllDaragat().subscribe(data =>{
      this.daragat = data;
    })
    this.client.GetAllBranches().subscribe(data =>{
      this.branches = data;
    })
    this.client.GetAllDeviceTypes().subscribe(data =>{
      this.options = data;
      this.filteredOptions = this.formFields.deviceType.valueChanges.pipe(
        startWith(''),
        map(value => this._filter(value))
      );
    })
    this.currentForm = this.formBuilder.group({
      daraga1: ['', [Validators.required]],
      name1: ['', [Validators.required, Validators.maxLength(100)]],
      branch: ['', [Validators.required]],
      daraga2: ['', [Validators.required]],
      name2: ['', [Validators.required, Validators.maxLength(100)]],
      problem: ['', [Validators.required, Validators.maxLength(250)]],
      deviceType: ['', [Validators.required, Validators.maxLength(50)]],
      model: ['', [Validators.required, Validators.maxLength(100)]],
      serial: ['', [Validators.maxLength(20)]],
  });

  }

  private _filter(value: string): DeviceType[] {
    const filterValue = value?.toLowerCase();
    return this.options.filter(option => option.type?.toLowerCase().indexOf(filterValue) === 0);
  }
  newTransaction!: Transaction;
  addTransaction() {
    if(this.isLoading) return;
    this.isLoading = true;
    this.newTransaction = {
      deviceBranchId: Number(this.formFields.branch.value),
      deviceSrialNumber : this.formFields.serial.value,
      deviceName: this.formFields.model.value,
      deviceType: {type: this.formFields.deviceType.value},
      problemDeescription: this.formFields.problem.value,
      ownerDaragaId:  Number(this.formFields.daraga1.value),
      ownerName: this.formFields.name1.value,
      reciverDaragaId:  Number(this.formFields.daraga2.value),
      reciverName: this.formFields.name2.value,
    };
    this.client.AddTransaction(this.newTransaction).subscribe(data =>{
      this.isLoading = false;
      alert("تم إضافة العملية");
    },
    error => {
      this.isLoading = false;
      alert("فشلت العملية");
    },);
  }
  reset() {
    this.formFields.daraga1.reset();
    this.formFields.name1.reset();
    this.formFields.branch.reset();
    this.formFields.daraga2.reset();
    this.formFields.name2.reset();
    this.formFields.problem.reset();
    this.formFields.deviceType.reset();
    this.formFields.model.reset();
    this.formFields.serial.reset();
  }
}
