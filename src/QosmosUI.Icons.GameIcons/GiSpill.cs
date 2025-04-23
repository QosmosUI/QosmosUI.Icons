// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSpill : ComponentBase
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
		builder.AddAttribute(14, "d", "M221.406 138.375c-43.425 0-69.357 30.627-6.375 30.625 43.426-.002 69.36-30.627 6.376-30.625zm136.688 17.438c-43.147 0-74.466 9.892-82.938 27.468-83.55-2.5-152.875 26.708-134.906 46.72 2.342 2.607.3 5.57-5.25 5.844-138.955 6.827-164.758 69.375-30.97 88.75 5.662.822 6.792 4.934 4.095 7.594-32.494 32.043 38.39 55.5 143.656 55.5 107.528 0 165.73-18.51 147.19-48.5-4.092-6.618-2.013-11.31 7-12.25 142.247-14.794 106.15-95.06-16.345-102.782-24.96-1.57-19.04-13.427-9.938-14.594 102.117-13.078 39.97-53.75-21.593-53.75zm93.625 203.28c-35.633.655-53.357 24.423 1.436 28.22 40.297 2.792 64.353-23.978 5.906-28.032-2.518-.173-4.968-.23-7.343-.186zm-344.345 40.313c-68.37.002-99.163 49.348 0 49.344 68.37-.002 99.163-49.348 0-49.344z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
