import http from 'k6/http';
import { sleep } from 'k6';

export default function () {
    // Request to the first API
    let res1 = http.get('https://localhost:7209/provinces');
    
    console.log('Response from localhost:7209/provinces:', res1.status);
    
    // Sleep for 1 second to simulate time between requests
    sleep(1);
}