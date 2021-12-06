import { Component, OnDestroy, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Items } from 'src/app/Models/Classes/Items';
import { ApiClientService } from 'src/app/Services/api-client.service';

@Component({
  selector: 'app-category-details',
  templateUrl: './category-details.component.html',
  styleUrls: ['./category-details.component.scss']
})
export class CategoryDetailsComponent implements AfterViewInit, OnDestroy {
  private sub!: Subscription;
  constructor(private client: ApiClientService, private route: ActivatedRoute, private  router: Router,) { }
  displayedColumns: string[] = ['name', 'quantity', 'price'];
  dataSource!: MatTableDataSource<Items>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  ngAfterViewInit() {
    this.sub = this.route.params.subscribe(params => {
      if (params.id) {
          this.client.GetItemsByCategoryId(params.id).subscribe(data => {
            console.log(data);
            this.dataSource = new MatTableDataSource(data);
            this.dataSource.paginator = this.paginator;
            this.dataSource.sort = this.sort;
          });
      }
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
}
