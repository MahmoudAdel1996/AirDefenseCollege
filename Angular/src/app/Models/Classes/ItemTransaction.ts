import { Items } from "./Items";
import { Person } from "./Person";

export class ItemTransaction {
    id!: number;
    items?: Items;
    itemsId!: number;
    transactionDate?: Date;
    handOverPerson!: Person;
    handOverPersonId?: number;
    reciverPerson!: Person;
    reciverPersonId?: number;
    quantity!: number;
    paid!: number;
}