.NET 9 results with 20 iterations
command -> k6 run --iterations 20 benchmark.js

result:
    execution: local
    script: benchmark.js
    output: -

    scenarios: (100.00%) 1 scenario, 1 max VUs, 10m30s max duration (incl. graceful stop):
         * default: 20 iterations shared among 1 VUs (maxDuration: 10m0s, gracefulStop: 30s)

    INFO[0000] Response from localhost:7209/provinces: 200   source=console
    INFO[0001] Response from localhost:7209/provinces: 200   source=console 
    INFO[0002] Response from localhost:7209/provinces: 200   source=console
    INFO[0003] Response from localhost:7209/provinces: 200   source=console
    INFO[0004] Response from localhost:7209/provinces: 200   source=console
    INFO[0005] Response from localhost:7209/provinces: 200   source=console
    INFO[0006] Response from localhost:7209/provinces: 200   source=console
    INFO[0007] Response from localhost:7209/provinces: 200   source=console
    INFO[0008] Response from localhost:7209/provinces: 200   source=console
    INFO[0009] Response from localhost:7209/provinces: 200   source=console
    INFO[0010] Response from localhost:7209/provinces: 200   source=console
    INFO[0011] Response from localhost:7209/provinces: 200   source=console
    INFO[0012] Response from localhost:7209/provinces: 200   source=console
    INFO[0013] Response from localhost:7209/provinces: 200   source=console
    INFO[0014] Response from localhost:7209/provinces: 200   source=console
    INFO[0015] Response from localhost:7209/provinces: 200   source=console
    INFO[0016] Response from localhost:7209/provinces: 200   source=console
    INFO[0017] Response from localhost:7209/provinces: 200   source=console
    INFO[0018] Response from localhost:7209/provinces: 200   source=console
    INFO[0019] Response from localhost:7209/provinces: 200   source=console

     data_received..................: 722 kB 36 kB/s
     data_sent......................: 4.5 kB 221 B/s
     http_req_blocked...............: avg=3.15ms   min=0s     med=0s      max=63.07ms p(90)=0s      p(95)=3.15ms
     http_req_connecting............: avg=27.02µs  min=0s     med=0s      max=540.4µs p(90)=0s      p(95)=27.02µs
     http_req_duration..............: avg=2.51ms   min=1.63ms med=2.25ms  max=5.98ms  p(90)=2.75ms  p(95)=2.94ms
       { expected_response:true }...: avg=2.51ms   min=1.63ms med=2.25ms  max=5.98ms  p(90)=2.75ms  p(95)=2.94ms
     http_req_failed................: 0.00%  0 out of 20
     http_req_receiving.............: avg=494.42µs min=0s     med=515.4µs max=752µs   p(90)=599.5µs p(95)=607.98µs
     http_req_sending...............: avg=3.1µs    min=0s     med=0s      max=62.1µs  p(90)=0s      p(95)=3.1µs
     http_req_tls_handshaking.......: avg=2.42ms   min=0s     med=0s      max=48.59ms p(90)=0s      p(95)=2.42ms
     http_req_waiting...............: avg=2.01ms   min=1.52ms med=1.73ms  max=5.98ms  p(90)=2.17ms  p(95)=2.37ms
     http_reqs......................: 20     0.993473/s
     iteration_duration.............: avg=1s       min=1s     med=1s      max=1.06s   p(90)=1s      p(95)=1s
     iterations.....................: 20     0.993473/s
     vus............................: 1      min=1       max=1
     vus_max........................: 1      min=1       max=1


.NET 8 results with 20 iterations
command -> k6 run --iterations 20 benchmark.js

    execution: local
    script: benchmark.js
    output: -
    
    scenarios: (100.00%) 1 scenario, 1 max VUs, 10m30s max duration (incl. graceful stop):
         * default: 20 iterations shared among 1 VUs (maxDuration: 10m0s, gracefulStop: 30s)

    INFO[0000] Response from localhost:7208/provinces: 200   source=console
    INFO[0001] Response from localhost:7208/provinces: 200   source=console
    INFO[0002] Response from localhost:7208/provinces: 200   source=console
    INFO[0003] Response from localhost:7208/provinces: 200   source=console
    INFO[0004] Response from localhost:7208/provinces: 200   source=console
    INFO[0005] Response from localhost:7208/provinces: 200   source=console
    INFO[0006] Response from localhost:7208/provinces: 200   source=console
    INFO[0007] Response from localhost:7208/provinces: 200   source=console
    INFO[0008] Response from localhost:7208/provinces: 200   source=console
    INFO[0009] Response from localhost:7208/provinces: 200   source=console
    INFO[0010] Response from localhost:7208/provinces: 200   source=console
    INFO[0011] Response from localhost:7208/provinces: 200   source=console
    INFO[0012] Response from localhost:7208/provinces: 200   source=console
    INFO[0013] Response from localhost:7208/provinces: 200   source=console
    INFO[0014] Response from localhost:7208/provinces: 200   source=console
    INFO[0015] Response from localhost:7208/provinces: 200   source=console
    INFO[0016] Response from localhost:7208/provinces: 200   source=console
    INFO[0017] Response from localhost:7208/provinces: 200   source=console
    INFO[0018] Response from localhost:7208/provinces: 200   source=console
    INFO[0019] Response from localhost:7208/provinces: 200   source=console

     data_received..................: 722 kB 36 kB/s
     data_sent......................: 5.0 kB 247 B/s
     http_req_blocked...............: avg=3.51ms   min=0s     med=0s       max=70.23ms p(90)=0s       p(95)=3.51ms
     http_req_connecting............: avg=33.74µs  min=0s     med=0s       max=674.9µs p(90)=0s       p(95)=33.74µs
     http_req_duration..............: avg=3.7ms    min=2.21ms med=3.05ms   max=10.52ms p(90)=5ms      p(95)=5.94ms
       { expected_response:true }...: avg=3.7ms    min=2.21ms med=3.05ms   max=10.52ms p(90)=5ms      p(95)=5.94ms
     http_req_failed................: 0.00%  0 out of 20
     http_req_receiving.............: avg=649.33µs min=0s     med=548.35µs max=1.39ms  p(90)=1.15ms   p(95)=1.22ms
     http_req_sending...............: avg=108.04µs min=0s     med=0s       max=627.7µs p(90)=512.04µs p(95)=518.26µs
     http_req_tls_handshaking.......: avg=2.71ms   min=0s     med=0s       max=54.32ms p(90)=0s       p(95)=2.71ms
     http_req_waiting...............: avg=2.95ms   min=1.72ms med=2.69ms   max=8.62ms  p(90)=3.49ms   p(95)=4.2ms
     http_reqs......................: 20     0.991877/s
     iteration_duration.............: avg=1s       min=1s     med=1s       max=1.07s   p(90)=1s       p(95)=1.01s
     iterations.....................: 20     0.991877/s
     vus............................: 1      min=1       max=1
     vus_max........................: 1      min=1       max=1


    running (00m20.2s), 0/1 VUs, 20 complete and 0 interrupted iterations
    default ✓ [======================================] 1 VUs  00m20.2s/10m0s  20/20 shared iters

Both applications run in Release mode in same machine with same configs.
