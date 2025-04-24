// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiUfc : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M6.308 7.843h2.797s-1.86 6.639-1.951 6.998c-.177.69-.353 1.316-2.043 1.316-2.037 0-3.22-.007-3.777 0-.698.007-1.521-.633-1.296-1.464l1.91-6.85H4.8S3.2 13.553 3.166 13.7c-.029.148-.19.557.698.564.64.014.69-.155.803-.564.268-.922 1.64-5.857 1.64-5.857zm10.272 0l-.507 1.824H9.986l.507-1.824zm-8.404 8.314l1.459-5.244h6.086l-.507 1.823h-3.262l-.95 3.421zm11.47-5.385c-.26.957-.493 1.774-.754 2.738-.05.17-.162.416-.127.57.078.367 1.29.226 1.726.226h1.945c-.155.612-.33 1.21-.5 1.81h-4.63c-.676-.064-1.557-.353-1.472-1.226.028-.274.156-.584.24-.887a1189.7 1189.7 0 001.24-4.463c.176-.648.317-1.197.83-1.457.333-.17.861-.218 1.255-.24H24c-.162.606-.331 1.211-.5 1.81h-2.643c-.317 0-.669-.036-.845.084-.19.141-.295.775-.366 1.035z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
