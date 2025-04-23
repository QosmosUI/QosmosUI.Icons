// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoMegaphone : ComponentBase
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
		builder.AddAttribute(14, "d", "M22 1.75v14.5a.75.75 0 0 1-.399.662c-.384.204-.783-.035-1.139-.248l-.003-.002c-.09-.054-.177-.107-.261-.15a15.53 15.53 0 0 0-2-.849c-1.738-.607-4.321-1.223-7.703-1.251a.833.833 0 0 1 .005.088c0 2.279.494 4.279.906 5.547.368 1.131-.438 2.453-1.732 2.453H7.661c-.696 0-1.36-.42-1.6-1.129C5.684 20.255 5 17.811 5 14.75v-.457A5.5 5.5 0 0 1 6.5 3.5h3.75c3.505 0 6.175-.61 7.955-1.21a15.88 15.88 0 0 0 2.002-.82 9.21 9.21 0 0 0 .49-.262c.048-.028.095-.055.142-.085A.751.751 0 0 1 22 1.75ZM10.5 12.912c3.564.029 6.313.678 8.193 1.335.737.258 1.34.517 1.807.74V2.993c-.467.216-1.073.467-1.815.718-1.878.634-4.624 1.26-8.185 1.288ZM6.5 5a4 4 0 0 0 0 8H9V5Zm0 9.75c0 2.847.638 5.123.982 6.141.018.051.074.109.179.109h2.013c.087 0 .179-.043.249-.147a.396.396 0 0 0 .057-.343C9.537 19.148 9 16.986 9 14.5H6.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
