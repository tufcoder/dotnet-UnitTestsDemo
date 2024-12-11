using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace UnitTestsDemo.Infrastructure.Configurations;

public class UlidToBytesConverter : ValueConverter<Ulid, byte[]>
{
    private static readonly ConverterMappingHints defaultHints = new ConverterMappingHints(
        size: 16
    );

    public UlidToBytesConverter()
        : this(null) { }

    public UlidToBytesConverter(ConverterMappingHints mappingHints = null)
        : base(
            convertToProviderExpression: x => x.ToByteArray(),
            convertFromProviderExpression: x => new Ulid(x),
            mappingHints: defaultHints.With(mappingHints)
        )
    { }
}
