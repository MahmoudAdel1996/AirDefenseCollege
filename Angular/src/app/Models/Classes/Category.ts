import { Items } from "./Items";

export class Category {
    id?: number;
    name!: string;
    items?: Items[];
    quantity!: number;
}