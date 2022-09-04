import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViaturasComponent } from './viaturas/viaturas.component';
import { PoliciaisComponent } from './policiais/policiais.component';
import { AbastecimentosComponent } from './abastecimentos/abastecimentos.component';
import { HttpClientModule } from '@angular/common/http'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {CollapseModule} from 'ngx-bootstrap/collapse'
import { NavComponent } from './nav/nav.component';
import { AbastecimentoService } from './services/abastecimento.service';
import { DateTimeFormatPipe } from './helpers/DateTimeFormat.pipe';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
      ViaturasComponent,
      PoliciaisComponent,
      AbastecimentosComponent,
      NavComponent,
      DateTimeFormatPipe,
      HomeComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot()
  ],
  providers: [
    AbastecimentoService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
