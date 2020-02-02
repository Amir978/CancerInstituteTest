import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-canc-inst-api',
  templateUrl: './canc-inst-api.component.html',
  styleUrls: ['./canc-inst-api.component.css']
})
export class CancInstApiComponent implements OnInit {
  @Input() palindromeData: Array<any>;
  
 
  constructor() { 
    console.log("Loading canc-inst-api (Saved Date) ...");
  }

  ngOnInit() {
  }

}
