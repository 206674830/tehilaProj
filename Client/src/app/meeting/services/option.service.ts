import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { City } from 'src/app/models/city';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class OptionService {

  
  private apiControllerName = 'Options'; 

  constructor(private http: HttpClient) { }

  getCities() : Observable<City[]>{
    return this.http.get<City[]>(`${environment.apiUrl}/${this.apiControllerName}/Cities`);
  }
}
