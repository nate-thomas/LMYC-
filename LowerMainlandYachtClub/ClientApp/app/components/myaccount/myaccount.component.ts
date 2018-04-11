import { Component } from '@angular/core';

@Component({
    selector: 'my-account',
    templateUrl: './myaccount.component.html',
    styleUrls: ['./myaccount.component.css', '../../../styles.css']
})
export class MyAccountComponent {
    loading: boolean = false;

    username: string = 'jsmith12';
    firstName: string = 'John';
    lastName: string = 'Smith';
    memberStatus: string = 'Full Memeber';
    skipperStatus: string = 'Crew';
    street: string = '123 LaLa St';
    city: string = 'Vancouver';
    province: string = 'BC';
    country: string = 'Canada';
    postalCode: string = 'V1C1A1';
    mobilePhone: string = '7781111111';
    homePhone: string = '7782222222';
    workPhone: string = '7782222222';
    credits: number = 111;
    sailingQualifications: string = 'n/a';
    skills: string = 'n/a';
    sailingExeprience: string = 'n/a';

    emergencyContact1Name: string = 'Jane Smith';
    emergencyContact1Phone: string = '6040000000';
    emergencyContact2Name: string = 'Isaac Toast';
    emergencyContact2Phone: string = '6040000001';

    //used to retrieve account info of the currenty logged in user.
    retrieveInfo() {
        this.loading = true; //is loading;
    }
}
