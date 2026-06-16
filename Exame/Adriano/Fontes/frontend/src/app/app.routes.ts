import { Routes } from '@angular/router';
import { MovimentosComponent } from './movimentos/movimentos.component';

export const routes: Routes = [
  { path: '', component: MovimentosComponent },   // rota padrão
  { path: 'movimentos', component: MovimentosComponent } // rota explícita
];
