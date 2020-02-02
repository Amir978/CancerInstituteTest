import { Component, EventEmitter, Input, Output, OnInit } from '@angular/core';

@Component({
  selector: 'app-canc-inst-pali-form',
  templateUrl: './canc-inst-pali-form.component.html',
  styleUrls: ['./canc-inst-pali-form.component.css']
})
export class CancInstPaliFormComponent implements OnInit {
  @Output() checkPalindrome = new EventEmitter<any>();
  @Input() palindromeInfo: any;
  @Input() returnedMessage: any;
  public buttonText = '-Save-';
 

  constructor() {
    console.log("Loading canc-inst-pali-form ...");
    this.clearPalindromeInfo();
    console.log("palindromeInfo:", this.palindromeInfo);
    
  }

  ngOnInit() {

  }

  private clearPalindromeInfo = function() {
    // Create an empty Palindrome object
    this.palindromeInfo = {
      id: undefined,
      phrase: '',
      dateAdded: undefined
    };
  };

  public addOrUpdatePalindromeRecord = function(event) {
    
    this.checkPalindrome.emit(this.palindromeInfo);
   
    
    this.clearPalindromeInfo();
  };
}
