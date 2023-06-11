import { Pipe, PipeTransform } from "@angular/core";
import { Meeting } from "src/app/models/meeting";

@Pipe({
    name: 'filter'
})
export class FilterPipe implements PipeTransform {
    transform(items: Meeting[], propName:string, filter: any): any {
        if (!items || !filter) {
            return items;
        }

        switch (propName) {
            case 'name':
                return items.filter(item => item.name?.indexOf(filter) !== -1);
           case 'cityId':
                return items.filter(item => item.cityId == +filter);
            case 'date':
                return items.filter(item => item.date.setHours(0,0,0,0).toString() == filter.setHours(0,0,0,0).toString() ) ;
            default:
                break;
        }         
 
        return items;
    }
}