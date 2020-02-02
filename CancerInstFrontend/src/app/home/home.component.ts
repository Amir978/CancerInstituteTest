import { Component, OnInit } from '@angular/core';
import { WorkoutService } from '../workout.service';
import * as _ from "lodash"

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  
  public palindromeData: Array<any>;
  public currentPalindrome: any;
  public returnedMessage = '';
  
  constructor (private workoutService: WorkoutService) {
    console.log("Loading Home ...");
    workoutService.get().subscribe((data: any) => this.palindromeData = data);
    this.currentPalindrome = this.setInitialValuesForPalindromeData();
  }
  private setInitialValuesForPalindromeData () {
    return {
      id: undefined,
      phrase: '',
      dateAdded: undefined
    }
  }
  public checkPalindrome = function(palindrome: any) {
    console.log("Data before check", this.palindromeData);
      this.workoutService.add(palindrome).subscribe(
        palindromeRecord => {
          palindrome.id = palindromeRecord.id;
          this.returnedMessage = "The phrase is added to DB. ";
          this.palindromeData.push(palindromeRecord)
        },
        error => {

          this.returnedMessage = "The phrase is NOT a Palindrome ";
          console.log(error);
        }
      );
       

    this.currentPalindrome = this.setInitialValuesForPalindromeData();
  };
  ngOnInit() {
  }

}
