import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Servidor } from '../models/Servidor';

@Injectable({
  providedIn: 'root'
})
export class ServidorService {

  constructor(private http:HttpClient) { }

  baseURL = 'https://localhost:5001/api/Servidor';

    public getServidores():Observable<Servidor[]> {
      return this.http.get<Servidor[]>(this.baseURL);
    }

    public getServidorById(id:number):Observable<Servidor> {
      return this.http.get<Servidor>(`${this.baseURL}/${id}`);
    }

}
