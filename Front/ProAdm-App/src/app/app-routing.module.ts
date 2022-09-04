import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AbastecimentosComponent } from './abastecimentos/abastecimentos.component';
import { HomeComponent } from './home/home.component';
import { PoliciaisComponent } from './policiais/policiais.component';
import { ViaturasComponent } from './viaturas/viaturas.component';

const routes: Routes = [
  {path:'home', component:HomeComponent},
  {path:'policial', component:PoliciaisComponent},
  {path:'abastecimento', component:AbastecimentosComponent},
  {path:'viatura', component:ViaturasComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
