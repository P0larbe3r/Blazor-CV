// Services/StorageService.cs
using Blazored.LocalStorage;

public class LocalStorageService
{
    private readonly ILocalStorageService _localStorage;

    public LocalStorageService(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public async Task SaveAsync<T>(string key, T value)
        => await _localStorage.SetItemAsync(key, value);

    public async Task<T?> LoadAsync<T>(string key)
        => await _localStorage.GetItemAsync<T>(key);

    public async Task RemoveAsync(string key)
        => await _localStorage.RemoveItemAsync(key);

    public async Task<bool> ExistsAsync(string key)
        => await _localStorage.ContainKeyAsync(key);
 
}