import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GClientComponent } from './gclient.component';

const routes: Routes = [{ path: '', component: GClientComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GClientRoutingModule { }
