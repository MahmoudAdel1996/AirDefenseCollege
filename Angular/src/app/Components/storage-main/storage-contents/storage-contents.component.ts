import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Category } from 'src/app/Models/Classes/Category';
import { ApiClientService } from 'src/app/Services/api-client.service';
import { AddCategoryDialogComponent } from './add-category-dialog/add-category-dialog.component';

@Component({
  selector: 'app-storage-contents',
  templateUrl: './storage-contents.component.html',
  styleUrls: ['./storage-contents.component.scss']
})
export class StorageContentsComponent implements OnInit {
  categories!: Category[];
  constructor(private client: ApiClientService, public dialog: MatDialog) { }

  ngOnInit(): void {

    this.client.GetCategoryWithQuantity().subscribe(data => {
      this.categories = data;
    });
  }
  addCategoryDialog(){
    const dialogRef = this.dialog.open(AddCategoryDialogComponent, {
      maxWidth: '850px',
      width: '100%',
      minWidth: '450px',
      data: this.categories
  })
    dialogRef.afterClosed().subscribe(_ => {
      this.ngOnInit();
    })
};
  
}
