#include <iostream>

using namespace std;

long long n;

/// Verificam daca este prim numarul
int VerifPrim(int n)
{
    if(n < 2)
        return 0;
    if(n == 2) return 1;
    for(int i = 2; i * i <= n; i++)
        if(n % i == 0)
            return 0;
    return 1;
}

/// Verificam numerele la care se imparte n daca sunt prime
int NrPrime(int n)
{
    for(int i = 2; i * i <= n; i++)
        if(n % i == 0 && VerifPrim(n / i))
            return 1;
    return 0;
}

int main()
{
    cin >> n;
    if(NrPrime(n))
        cout << "DA";
    else cout << "NU";
    return 0;
}
