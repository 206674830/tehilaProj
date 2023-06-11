import { City } from "./city";
import { Participant } from "./participants";

export class Meeting {

    id?: number;
    name?: string;
    date: Date = new Date();
    cityId?: number;
    city?: City;
    participants?: Participant[]
    /**
     *
     */
    constructor() {
        this.participants = [];

    }
}