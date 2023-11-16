import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SectionComponent } from 'src/app/common/components/blank/section/section.component';
import { NavModel } from 'src/app/common/components/blank/models/nav.model';
import { BlankComponent } from 'src/app/common/components/blank/blank.component';

@Component({
  selector: 'app-ucaf',
  standalone: true,
  imports: [CommonModule,BlankComponent,SectionComponent],

  templateUrl: './ucafs.component.html',
  styleUrls: ['./ucafs.component.css']
})
export class UcafComponent {
navs: NavModel[]=[
  {
    routerLink:"/",
    class:"",
    name:"Ana Sayfa"
  },
  {
    routerLink:"/ucafs",
    class:"active",
    name:"Hesap Planı"
  }
]
}
