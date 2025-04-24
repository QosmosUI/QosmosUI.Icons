// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscSearchFuzzy : ComponentBase
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
		builder.AddAttribute(14, "d", "M8 1.5C5.51472 1.5 3.5 3.51472 3.5 6C3.5 7.20114 3.9706 8.29237 4.73749 9.09937L1.04291 12.7939L1.75001 13.5011L5.5053 9.74577C6.2193 10.2222 7.07721 10.5 8 10.5C10.4853 10.5 12.5 8.48528 12.5 6C12.5 3.51472 10.4853 1.5 8 1.5ZM4.5 6C4.5 4.067 6.067 2.5 8 2.5C9.933 2.5 11.5 4.067 11.5 6C11.5 7.933 9.933 9.5 8 9.5C6.067 9.5 4.5 7.933 4.5 6Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M8.99998 13.8546L6.85353 16.0011H6.14642L4.64642 14.5011L5.35353 13.7939L6.49998 14.9404L8.64642 12.7939H9.35353L11.5 14.9404L13.6464 12.7939H14.3535L16 14.4404V15.8546L14 13.8546L11.8535 16.0011H11.1464L8.99998 13.8546Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
