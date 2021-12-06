import { Moment } from "moment";
import { Branch } from "./Branch";
import { Daraga } from "./Daraga";
import { DeviceState } from "./DeviceState";
import { DeviceType } from "./DeviceType";

export class Transaction {
    id?: number;
    enterDate?: Date;
    exitDate?: Date;
    ownerDaraga?: Daraga;
    ownerDaragaId!: number;
    ownerName!: string;
    reciverDaraga?: Daraga;
    reciverDaragaId!: number;
    reciverName!: string;
    handOverToDaraga?: Daraga;
    handOverToDaragaId?: number;
    handOverToName?: string;
    deviceType!: DeviceType;
    deviceTypeId?: number;
    deviceName!: string;
    deviceSrialNumber!: string;
    deviceBranch?: Branch;
    deviceBranchId!: number;
    problemDeescription!: string;
    notes?: string;
    deviceState?: DeviceState;
    deviceStateId?: number;
}