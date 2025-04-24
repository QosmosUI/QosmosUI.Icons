// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTelefrag : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M256 16c-59.998 0-120 30-120 75 0 30 22.5 45 22.5 75 0 22.5-7.5 22.5-7.5 37.5 0 7.5 24.006 16.002 45 22.5v30h120v-30s45.283-13.978 45-22.5c-.465-13.974-7.5-15-7.5-37.5 0-15 22.82-45.71 22.5-75 0-45-60.002-75-120-75zm-45 90c16.57 0 30 13.433 30 30 0 16.568-13.43 30-30 30s-30-13.432-30-30c0-16.567 13.43-30 30-30zm90 0c16.567 0 30 13.433 30 30 0 16.568-13.432 30-30 30-16.57 0-30-13.432-30-30 0-16.567 13.43-30 30-30zm-45 52.5c7.5 0 22.5 30 22.5 37.5 0 15 0 15-7.5 15h-30c-7.5 0-7.5 0-7.5-15 0-7.5 15-37.5 22.5-37.5zM136 286v45h240v-45H136zm0 75v45h240v-45H136zm-30 75c-15 0-30 15-30 30v30h360v-30c0-15-15-30-30-30H106z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
