Todas as entradas e saída dos algoritmos são utilizados o STDIN e STDOUT de cada linguagem, abaixo tem algumas dicas de como utilizar cada STDIN e STDOUT de cada linguagem.

### JavaScript

Em JavaScript as funções de STDIN e STDOUT respectivamente sãogets e console.log, a função gets é implementada internamente para auxiliar a entrada dos dados.

### Exemplo:

```javascript
let line = gets(); // Retorna a próxima linha de entrada

console.log(line); // Imprime o dado
```
### Java

Em Java existe várias formas de implementar o STDIN e STDOUT recomendamos utilizar BufferedReader para o STDIN e o System.out.println para o STDOUT.

### Exemplo:
```java
BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

StringTokenizer st = new StringTokenizer(br.readLine()); // Lê a linha de entrada

int a = Integer.parseInt(st.nextToken());

System.out.println(a); // Imprime o dado
```
### Python

Em Python existe várias formas de implementar o STDIN e STDOUT recomendamos utilizar sys.stdin.readline para o STDIN e o print para o STDOUT.

### Exemplo:
```python
import sys

a = int(sys.stdin.readline()) // Lê a linha de entrada

print(a); // Imprime o dado
```