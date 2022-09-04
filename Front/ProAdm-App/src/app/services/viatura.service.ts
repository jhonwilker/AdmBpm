import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Viatura } from '../models/Viatura';

@Injectable({
  providedIn: 'root'
})
export class ViaturaService {

constructor(private http:HttpClient) { }

baseURL = 'https://localhost:5001/api/Viatura';

  public getServidores():Observable<Viatura[]> {
    return this.http.get<Viatura[]>(this.baseURL);
  }

  public getServidorById(id:number):Observable<Viatura> {
    return this.http.get<Viatura>(`${this.baseURL}/${id}`);
  }
}
