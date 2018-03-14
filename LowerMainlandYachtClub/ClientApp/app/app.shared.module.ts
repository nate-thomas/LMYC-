import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { RulesAndRegulationsComponent } from './components/rulesandregulations/rulesandregulations.component';
import { MyAccountComponent } from './components/myaccount/myaccount.component';
import { FleetComponent } from './components/about/fleet/fleet.component';
import { HistoryComponent } from './components/about/history/history.component';
import { AboutComponent } from './components/about/about.component';
import { BookingComponent } from './components/booking/booking.component';
import { EventsComponent } from './components/events/events.component';
import { FooterComponent } from './components/footer/footer.component';
import { MembershipComponent } from './components/membership/membership.component';
import { ReservationsComponent } from './components/myaccount/reservations/reservations.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        RulesAndRegulationsComponent,
        MyAccountComponent,
        ReservationsComponent,
        MembershipComponent,
        FooterComponent,
        EventsComponent,
        BookingComponent,
        AboutComponent,
        FleetComponent,
        HistoryComponent,
        HomeComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
