import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddTransactionComponent } from './Components/wrsha-main/add-transaction/add-transaction.component';
import { FixTransactionsComponent } from './Components/wrsha-main/fix-transactions/fix-transactions.component';
import { StorageMainComponent } from './Components/storage-main/storage-main.component';
import { ItemHandOverComponent } from './Components/storage-main/item-hand-over/item-hand-over.component';
import { StorageContentsComponent } from './Components/storage-main/storage-contents/storage-contents.component';
import { StorageHistoryComponent } from './Components/storage-main/storage-history/storage-history.component';
import { WrshaMainComponent } from './Components/wrsha-main/wrsha-main.component';
import { AddItemComponent } from './Components/storage-main/add-item/add-item.component';
import { CategoryDetailsComponent } from './Components/storage-main/storage-contents/category-details/category-details.component';
import { LoginComponent } from './Components/login/login.component';
import { AuthGuard } from './Helper/auth.guard';

const routes: Routes = [
  {path: '', redirectTo: 'wrsha/fix-transactions', pathMatch: 'full'},
  { 
    path: 'wrsha',
    component: WrshaMainComponent,
    children: [
      {
        path : 'fix-transactions',
        component: FixTransactionsComponent,
        canActivate: [AuthGuard]
        
       },
       {
        path : 'add-transaction',
        component: AddTransactionComponent,
        canActivate: [AuthGuard]
       },
    ],
    canActivate: [AuthGuard]
  },
  {
    path: 'storage',
    component: StorageMainComponent,
    children:[
    {
     path : 'preview',
     component: StorageContentsComponent,
     canActivate: [AuthGuard]
    },
    {
      path :'details/:id',
      component: CategoryDetailsComponent,
      canActivate: [AuthGuard]
    },
    {
    path : 'hand-over-item',
    component: ItemHandOverComponent,
    canActivate: [AuthGuard]
    },
    {
    path : 'add-item',
    component: AddItemComponent,
    canActivate: [AuthGuard]
    },
    {
    path : 'history',
    component: StorageHistoryComponent,
    canActivate: [AuthGuard]
    }
  ],
  canActivate: [AuthGuard]
  },
  { path: 'login', component: LoginComponent },
  // otherwise redirect to home
  { path: '**', redirectTo: 'wrsha/fix-transactions', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
