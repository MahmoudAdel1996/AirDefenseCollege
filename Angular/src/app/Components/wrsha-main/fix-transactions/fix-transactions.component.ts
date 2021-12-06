import { Component, AfterViewInit, ViewChild  } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { StaticVariables } from 'src/app/Models/Classes/AllStaticVariables';
import { Transaction } from 'src/app/Models/Classes/Transaction';
import { ApiClientService } from 'src/app/Services/api-client.service';
import { FixDialogComponent } from '../../fix-dialog/fix-dialog.component';
import { HandOverDialogComponent } from '../../hand-over-dialog/hand-over-dialog.component';
import { NoteDialogComponent } from '../../note-dialog/note-dialog.component';
import { ProblemDiscriptionDialogComponent } from '../../problem-discription-dialog/problem-discription-dialog.component';

@Component({
  selector: 'app-fix-transactions',
  templateUrl: './fix-transactions.component.html',
  styleUrls: ['./fix-transactions.component.scss']
})
export class FixTransactionsComponent implements AfterViewInit {

  displayedColumns: string[] = [
    'id', 'deviceType', 'deviceName','deviceSrialNumber','deviceBranchId', 'ownerDaragaId', 'ownerName', 'reciverDaragaId', 'reciverName', 
    'handOverToDaragaId', 'handOverToName','enterDate', 'exitDate',
    'problemDeescription', 'notes', 'deviceStateId'
   ];
  dataSource!: MatTableDataSource<Transaction>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private client: ApiClientService, public dialog: MatDialog,public staticVariable: StaticVariables ) {}

  ngAfterViewInit() {
    this.client.GetAllTransactions().subscribe(data =>{
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    })
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  openFixDialog(transaction: Transaction){
    transaction.deviceState = undefined;
    transaction.deviceStateId = 2;
    this.client.UpdateTransaction(transaction).subscribe();
    const dialogRef = this.dialog.open(FixDialogComponent, {
      width: '250px'
    });
    dialogRef.afterClosed().subscribe(result => {
      this.ngAfterViewInit();
    });
  }
  openHandOverDialog(transaction: Transaction){
    const dialogRef = this.dialog.open(HandOverDialogComponent, {
      maxWidth: '850px',
      width: '100%',
      minWidth: '450px',
      data: transaction
    });

    dialogRef.afterClosed().subscribe(result => {
      this.ngAfterViewInit();
    });
  }
  openProblemDescriptionDialog(transaction: Transaction){
    const dialogRef = this.dialog.open(ProblemDiscriptionDialogComponent, {
      maxWidth: '850px',
      width: '100%',
      minWidth: '450px',
      data: transaction
    });

    dialogRef.afterClosed().subscribe(result => {
      this.ngAfterViewInit();
    });
  }
  openNotesDialog(transaction: Transaction){
    const dialogRef = this.dialog.open(NoteDialogComponent, {
      maxWidth: '850px',
      width: '100%',
      minWidth: '450px',
      data: transaction
    });

    dialogRef.afterClosed().subscribe(result => {
      this.ngAfterViewInit();
    });
  }
}