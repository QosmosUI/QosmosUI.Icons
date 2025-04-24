// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPagseguro : ComponentBase
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
		builder.AddAttribute(15, "d", "M17.482 9.712c1.64 0 3.108.69 4.1 1.813.044-.388.087-.777.087-1.208C21.67 5.007 17.353.69 12 .69c-5.353 0-9.67 4.316-9.67 9.626 0 .345 0 .69.044 1.036a8.688 8.688 0 017.943-5.137c2.848 0 5.352 1.381 6.95 3.496h.215zm-7.122-2.72c-4.36 0-7.9 3.54-7.9 7.9s3.54 7.9 7.9 7.9c2.158 0 4.1-.864 5.525-2.245a5.53 5.53 0 01-3.928-5.31c0-2.676 1.9-4.92 4.446-5.438-1.468-1.684-3.626-2.806-6.043-2.806zM4.79 21.583A11.958 11.958 0 010 12C0 5.353 5.396 0 12 0s12 5.396 12 12-5.396 12-12 12c-1.554 0-3.022-.302-4.36-.82-1.079-.389-2.028-.907-2.849-1.597zm12.777-1.51a4.827 4.827 0 004.835-4.835 4.827 4.827 0 00-4.835-4.834 4.827 4.827 0 00-4.834 4.834 4.827 4.827 0 004.834 4.835Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
