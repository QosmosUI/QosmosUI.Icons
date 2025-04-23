// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImPaypal : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M14.531 4.822c-0.747 3.316-3.053 5.066-6.688 5.066h-1.209l-0.841 5.338h-1.013l-0.053 0.344c-0.034 0.228 0.141 0.431 0.369 0.431h2.588c0.306 0 0.566-0.222 0.616-0.525l0.025-0.131 0.488-3.091 0.031-0.169c0.047-0.303 0.309-0.525 0.616-0.525h0.384c2.506 0 4.469-1.019 5.044-3.963 0.216-1.119 0.134-2.069-0.356-2.775z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M12.984 1.206c-0.741-0.844-2.081-1.206-3.794-1.206h-4.972c-0.35 0-0.65 0.253-0.703 0.6l-2.072 13.131c-0.041 0.259 0.159 0.494 0.422 0.494h3.072l0.772-4.891-0.025 0.153c0.053-0.347 0.35-0.6 0.7-0.6h1.459c2.866 0 5.109-1.162 5.766-4.531 0.019-0.1 0.037-0.197 0.050-0.291 0.194-1.244 0-2.094-0.675-2.859z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
