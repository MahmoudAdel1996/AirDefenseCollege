import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './Components/header/header.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule} from '@angular/material/table';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { MatCardModule } from '@angular/material/card';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatMenuModule } from '@angular/material/menu';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatRadioModule } from '@angular/material/radio';
import { MatRippleModule } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatSortModule } from '@angular/material/sort';
import { MatTooltipModule } from '@angular/material/tooltip';
import { WrshaMainComponent } from './Components/wrsha-main/wrsha-main.component';
import { HttpClientModule } from '@angular/common/http';
import { AddTransactionComponent } from './Components/wrsha-main/add-transaction/add-transaction.component';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FixDialogComponent } from './Components/fix-dialog/fix-dialog.component';
import { HandOverDialogComponent } from './Components/hand-over-dialog/hand-over-dialog.component';
import { ProblemDiscriptionDialogComponent } from './Components/problem-discription-dialog/problem-discription-dialog.component';
import { NoteDialogComponent } from './Components/note-dialog/note-dialog.component';
import {MatDialogModule} from '@angular/material/dialog';
import { DatePipe, registerLocaleData } from '@angular/common';
import localeEn from '@angular/common/locales/en';
import { StorageMainComponent } from './Components/storage-main/storage-main.component';
import {MatSidenavModule} from '@angular/material/sidenav';
import { FixTransactionsComponent } from './Components/wrsha-main/fix-transactions/fix-transactions.component';
import { StorageContentsComponent } from './Components/storage-main/storage-contents/storage-contents.component';
import { ItemHandOverComponent } from './Components/storage-main/item-hand-over/item-hand-over.component';
import { AddItemComponent } from './Components/storage-main/add-item/add-item.component';
import { StorageHistoryComponent } from './Components/storage-main/storage-history/storage-history.component';
import { CategoryDetailsComponent } from './Components/storage-main/storage-contents/category-details/category-details.component';
import { AddCategoryDialogComponent } from './Components/storage-main/storage-contents/add-category-dialog/add-category-dialog.component';
import { LoginComponent } from './Components/login/login.component';
import { NgxDocViewerModule } from 'ngx-doc-viewer';
registerLocaleData(localeEn, 'en')
@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    WrshaMainComponent,
    AddTransactionComponent,
    FixDialogComponent,
    HandOverDialogComponent,
    ProblemDiscriptionDialogComponent,
    NoteDialogComponent,
    StorageMainComponent,
    FixTransactionsComponent,
    StorageContentsComponent,
    ItemHandOverComponent,
    AddItemComponent,
    StorageHistoryComponent,
    CategoryDetailsComponent,
    AddCategoryDialogComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatTableModule,
    MatFormFieldModule,
    MatCheckboxModule,
    MatButtonToggleModule,
    MatCardModule,
    MatGridListModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatTooltipModule,
    MatAutocompleteModule,
    MatDialogModule,
    MatSidenavModule,
    NgxDocViewerModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
