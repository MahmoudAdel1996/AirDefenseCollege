import { Branch } from "./Branch";
import { Daraga } from "./Daraga";

export class Person {
    id?: number;
    daraga?: Daraga;
    daragaId!: number;
    name!: string;
    branch?: Branch;
    branchId!: number;
}