import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Servidor } from '../models/Servidor';
import { ServidorService } from '../services/servidor.service';

@Component({
  selector: 'app-policiais',
  templateUrl: './policiais.component.html',
  styleUrls: ['./policiais.component.scss']
})
export class PoliciaisComponent implements OnInit {

  public policiais : Servidor[] = [];

  constructor(private servidorService:ServidorService) {

   }

  ngOnInit() {
    this.getPoliciais();
  }

  public getPoliciais():void {

    this.servidorService.getServidores().subscribe(

      (_servidores:Servidor[]) => {
        this.policiais = _servidores;
      },
      error => console.log(error)
    );

  }

}
