import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Branch } from '../Models/Classes/Branch';
import { Category } from '../Models/Classes/Category';
import { Daraga } from '../Models/Classes/Daraga';
import { Device } from '../Models/Classes/Device';
import { DeviceState } from '../Models/Classes/DeviceState';
import { DeviceTransaction } from '../Models/Classes/DeviceTransaction';
import { DeviceType } from '../Models/Classes/DeviceType';
import { Item } from '../Models/Classes/Item';
import { Items } from '../Models/Classes/Items';
import { ItemTransaction } from '../Models/Classes/ItemTransaction';
import { Person } from '../Models/Classes/Person';
import { Transaction } from '../Models/Classes/Transaction';

@Injectable({
  providedIn: 'root'
})
export class ApiClientService {

  public static httpHeaders = new HttpHeaders({
    'Content-Type': 'application/json',
    Accept: 'application/json',
  });
  // SERVER_URL = "http://100.100.3.100:90/api"
  SERVER_URL = "https://localhost:44336/api"
  constructor(private http: HttpClient) {
  }
// Branches
  public GetAllBranches(): Observable<Branch[]> {
      return this.http.get<Daraga[]>(`${this.SERVER_URL}/Branchs`);
  }


// Daragat
  public GetAllDaragat(): Observable<Daraga[]> {
      return this.http.get<Daraga[]>(`${this.SERVER_URL}/Daragat`);
  }


// Devices
  public GetAllDevices(): Observable<Device[]> {
      return this.http.get<Device[]>(`${this.SERVER_URL}/Devices`);
  }


// DeviceStates
  public GetAllDeviceStates(): Observable<DeviceState[]> {
      return this.http.get<DeviceState[]>(`${this.SERVER_URL}/DeviceStates`);
  }


// DeviceTransactions
  public GetAllDeviceTransactions(): Observable<DeviceTransaction[]> {
      return this.http.get<DeviceTransaction[]>(`${this.SERVER_URL}/DeviceTransactions`);
  }


// DeviceTypes
  public GetAllDeviceTypes(): Observable<DeviceType[]> {
      return this.http.get<DeviceType[]>(`${this.SERVER_URL}/DeviceTypes`);
  }

  
// Tranxsactions
  public GetAllTransactions(): Observable<Transaction[]> {
      return this.http.get<Transaction[]>(`${this.SERVER_URL}/Transactions`);
  }

  public AddTransaction(newTransaction: Transaction): Observable<any>{
      return this.http.post<Transaction>(`${this.SERVER_URL}/Transactions`, newTransaction, {headers: ApiClientService.httpHeaders});
  }

  public UpdateTransaction(newTransaction: Transaction): Observable<any>{
      return this.http.put<Transaction>(`${this.SERVER_URL}/Transactions/${newTransaction.id}`, newTransaction, {headers: ApiClientService.httpHeaders});
  }

  public UpdateTransactionHandOver(newTransaction: Transaction): Observable<any>{
      return this.http.put<Transaction>(`${this.SERVER_URL}/Transactions/EditHandOverTransaction/${newTransaction.id}`, newTransaction, {headers: ApiClientService.httpHeaders});
  }


  // Storage

  // Category
  public GetAllCategory(): Observable<Category[]> {
    return this.http.get<Category[]>(`${this.SERVER_URL}/Category`);
  }

  public GetCategoryWithQuantity(): Observable<Category[]> {
    return this.http.get<Category[]>(`${this.SERVER_URL}/Items/GetCategoryWithQuantity`);
  }

  public GetItemsByCategoryId(CategoryId: number): Observable<Items[]> {
    return this.http.get<Items[]>(`${this.SERVER_URL}/Category/details/${CategoryId}`);
  }

  public AddCategory(newCategory: Category): Observable<any>{
      return this.http.post<Category>(`${this.SERVER_URL}/Category`, newCategory, {headers: ApiClientService.httpHeaders});
  }

  public UpdateCategory(newCategory: Category): Observable<any>{
      return this.http.put<Category>(`${this.SERVER_URL}/Category/${newCategory.id}`, newCategory, {headers: ApiClientService.httpHeaders});
  }
  public DeleteCategory(categoryId: number): Observable<any>{
    return this.http.delete<any>(`${this.SERVER_URL}/Category/${categoryId}`, {headers: ApiClientService.httpHeaders});
  }

  
  // Person
  public GetAllPerson(): Observable<Person[]> {
    return this.http.get<Person[]>(`${this.SERVER_URL}/Person`);
  }

  public AddPerson(newPerson: Person): Observable<any>{
      return this.http.post<Person>(`${this.SERVER_URL}/Person`, newPerson, {headers: ApiClientService.httpHeaders});
  }

  public UpdatePerson(newPerson: Person): Observable<any>{
      return this.http.put<Person>(`${this.SERVER_URL}/Person/${newPerson.id}`, newPerson, {headers: ApiClientService.httpHeaders});
  }
  public DeletePerson(personId: number): Observable<any>{
    return this.http.delete<any>(`${this.SERVER_URL}/Person/${personId}`, {headers: ApiClientService.httpHeaders});
}

    // Items
    public GetAllItems(): Observable<Items[]> {
      return this.http.get<Items[]>(`${this.SERVER_URL}/Items`);
    }

    public GetItemById(itemId: number): Observable<Items> {
      return this.http.get<Items>(`${this.SERVER_URL}/Items/${itemId}`);
    }

    public AddItems(newItems: Items): Observable<any>{
        return this.http.post<Items>(`${this.SERVER_URL}/Items`, newItems, {headers: ApiClientService.httpHeaders});
    }
  
    public UpdateItems(newItems: Items): Observable<any>{
        return this.http.put<Items>(`${this.SERVER_URL}/Items/${newItems.id}`, newItems, {headers: ApiClientService.httpHeaders});
    }
    public UpdateItemsWithoutName(newItems: Items): Observable<any>{
        return this.http.put<Items>(`${this.SERVER_URL}/Items/editWithOutName/${newItems.id}`, newItems, {headers: ApiClientService.httpHeaders});
    }
    public DeleteItems(itemsId: number): Observable<any>{
      return this.http.delete<any>(`${this.SERVER_URL}/Items/${itemsId}`, {headers: ApiClientService.httpHeaders});
  }

    
    // ItemTransaction
    public GetAllItemTransaction(): Observable<ItemTransaction[]> {
      return this.http.get<ItemTransaction[]>(`${this.SERVER_URL}/ItemTransaction`);
    }
  
    public AddItemTransaction(newItemTransaction: ItemTransaction): Observable<any>{
        return this.http.post<ItemTransaction>(`${this.SERVER_URL}/ItemTransaction`, newItemTransaction, {headers: ApiClientService.httpHeaders});
    }

    public EditDocument2AT(names: string | undefined, quantity: number): Observable<any>{
      return this.http.post<any>(`${this.SERVER_URL}/ItemTransaction/Edit2ADocument/${names}/${quantity}`, {headers: ApiClientService.httpHeaders});
    }
  
    public UpdateItemTransaction(newItemTransaction: ItemTransaction): Observable<any>{
        return this.http.put<ItemTransaction>(`${this.SERVER_URL}/ItemTransaction/${newItemTransaction.id}`, newItemTransaction, {headers: ApiClientService.httpHeaders});
    }

    public DeleteItemTransaction(newItemTransactionId: number): Observable<any>{
      return this.http.delete<any>(`${this.SERVER_URL}/ItemTransaction/${newItemTransactionId}`, {headers: ApiClientService.httpHeaders});
  }
}
