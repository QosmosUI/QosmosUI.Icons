// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiBell : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M19.715 17.301c-.017-.018-1.717-1.854-1.73-6.32-.009-2.607-1.69-4.824-4.019-5.641l.034-.34c0-1.103-.896-2-2-2s-2 .897-2 2l.034.338c-2.336.816-4.019 3.036-4.019 5.646 0 4.462-1.711 6.296-1.721 6.306-.287.286-.374.716-.22 1.091s.521.619.926.619h3.143c.447 1.72 1.999 3 3.857 3s3.41-1.28 3.857-3h3.143c.4 0 .758-.243.915-.61s.076-.799-.2-1.089zm-7.715-10.301c2.189 0 3.978 1.789 3.984 3.987.002.728.046 1.396.118 2.013h-8.2c.071-.617.113-1.286.113-2.016.001-2.196 1.788-3.984 3.985-3.984zm0 13c-.737 0-1.375-.405-1.722-1h3.443c-.346.595-.984 1-1.721 1zm-5.186-3c.352-.736.705-1.731.938-3h8.502c.234 1.269.588 2.264.938 3h-10.378z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
