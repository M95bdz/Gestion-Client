import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap'; 
import { GClientRoutingModule } from './gclient-routing.module';
import { GClientComponent } from './gclient.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [GClientComponent],
  imports: [
  
    GClientRoutingModule,
    SharedModule,
    NgbDatepickerModule,
  ]
})
export class GClientModule { }
