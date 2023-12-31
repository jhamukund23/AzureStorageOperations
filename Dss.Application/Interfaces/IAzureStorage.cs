using Dss.Domain.DTOs;
using Microsoft.AspNetCore.Http;

namespace Dss.application.Interfaces;

public interface IAzureStorage
{
    Task<BlobResponseDto> UploadAsync(IFormFile file);
    Task<BlobResponseDto> UploadWithSASUrlAsync(IFormFile file, string sasUrl);
    Task<BlobResponseDto> UploadAsync(Stream content, string contentType, string fileName);
    Task<BlobDto?> DownloadAsync(string blobFilename);
    Task<BlobResponseDto> DeleteAsync(string blobFilename);
    Task<List<BlobDto>> ListAsync();
    Uri? GetServiceSasUriForContainer(string? storedPolicyName = null);
    Task<Uri?> GetServiceSasUriForContainerAsync(string? storedPolicyName = null);
    Task<BlobResponseDto?> UploadFileInDatalakeWithSASUrlAsync(IFormFile blob, string sasUri);
    //Task<Uri> GetServiceSasUriForBlob(BlobClient blobClient, string storedPolicyName = null);

}
