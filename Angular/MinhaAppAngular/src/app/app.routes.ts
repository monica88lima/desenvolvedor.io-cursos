import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './componentes/home/home.component';
import { ContatoComponent } from './componentes/contato/contato.component';
import { SobreComponent } from './componentes/sobre/sobre.component';
import { ProdutosComponent } from './componentes/produtos/produtos.component';
import { FeaturesComponent } from './componentes/features/features.component';
import { NgModule } from '@angular/core';
import { DataBComponent } from './dataBind/data-b/data-b.component';

export const routes: Routes = [
  {	path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent},
   { path: 'contato', component: ContatoComponent},
   { path: 'sobre', component: SobreComponent},
   { path: 'produtos', component: ProdutosComponent},
   { path: 'features', component: FeaturesComponent},
   { path: 'dataB', component: DataBComponent},
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

