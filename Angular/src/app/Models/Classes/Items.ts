import { Category } from "./Category";
import { Item } from "./Item";

export class Items {
    id?: number;
    name!: string;
    category?: Category;
    categoryId!: number;
    quantity!: number;
    price!: number;
    sameTypeItems?: Item[]
}