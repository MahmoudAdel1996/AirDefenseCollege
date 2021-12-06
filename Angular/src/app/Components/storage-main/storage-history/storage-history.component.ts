import { Component, OnDestroy, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { StaticVariables } from 'src/app/Models/Classes/AllStaticVariables';
import { Daraga } from 'src/app/Models/Classes/Daraga';
import { ItemTransaction } from 'src/app/Models/Classes/ItemTransaction';
import { Person } from 'src/app/Models/Classes/Person';
import { ApiClientService } from 'src/app/Services/api-client.service';

@Component({
  selector: 'app-storage-history',
  templateUrl: './storage-history.component.html',
  styleUrls: ['./storage-history.component.scss']
})
export class StorageHistoryComponent implements AfterViewInit {
  constructor(private client: ApiClientService, public staticVariable: StaticVariables) { }
  displayedColumns: string[] = ['itemName', 'quantity', 'reciverDaragaId','reciverName', 'transactionDate', 'handOverToDaragaId', 'handOverToName', 'paid'];
  dataSource!: MatTableDataSource<ItemTransaction>;
  daragat!: Daraga[];
  persons!: Person[];
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  ngAfterViewInit() {
      this.client.GetAllItemTransaction().subscribe(data => {
        this.dataSource = new MatTableDataSource(data);
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
      });
  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  printDocument(row: ItemTransaction){
    this.client.EditDocument2AT(row.items?.name , row.quantity).subscribe(_=>{},
      error => {
        alert("فشلت العملية");
      }
      );
  }
}
