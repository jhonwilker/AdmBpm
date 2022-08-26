import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-policiais',
  templateUrl: './policiais.component.html',
  styleUrls: ['./policiais.component.scss']
})
export class PoliciaisComponent implements OnInit {

  public policiais :any;

  constructor(private http:HttpClient) {

   }

  ngOnInit() {
    this.getPoliciais();
  }

  public getPoliciais():void {

    this.http.get('https://localhost:5001/api/Servidor').subscribe(
      response => this.policiais = response,
      error => console.log(error)
    );

  }

}
