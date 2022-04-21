package main

import (
	"fmt"
	"net/http"
)

func main() {
	http.HandleFunc("/", HelloServer)

	host := "localhost"
	port := 8000

	fmt.Printf("Server is running on http://%s:%v\n", host, port)

	http.ListenAndServe(fmt.Sprintf(":%v", port), nil)
}

func HelloServer(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "Hello World!", r.URL.Path[1:])
}
