// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscRobot : ComponentBase
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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M8 8C8 9.10457 7.10457 10 6 10C4.89543 10 4 9.10457 4 8C4 6.89543 4.89543 6 6 6C7.10457 6 8 6.89543 8 8ZM5 8C5 8.55228 5.44772 9 6 9C6.55228 9 7 8.55228 7 8C7 7.44772 6.55228 7 6 7C5.44772 7 5 7.44772 5 8Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "fill-rule", "evenodd");
		builder.AddAttribute(19, "clip-rule", "evenodd");
		builder.AddAttribute(20, "d", "M8 8C8 9.10457 8.89543 10 10 10C11.1046 10 12 9.10457 12 8C12 6.89543 11.1046 6 10 6C8.89543 6 8 6.89543 8 8ZM11 8C11 8.55228 10.5523 9 10 9C9.44772 9 9 8.55228 9 8C9 7.44772 9.44772 7 10 7C10.5523 7 11 7.44772 11 8Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "fill-rule", "evenodd");
		builder.AddAttribute(23, "clip-rule", "evenodd");
		builder.AddAttribute(24, "d", "M8.51001 11.251C9.02924 11.1436 9.50557 10.8864 9.88001 10.511L10.58 11.221C9.89283 11.901 8.96678 12.2851 8.00001 12.291C7.51235 12.2873 7.03006 12.1888 6.58001 12.001C6.13507 11.8188 5.73061 11.5503 5.39001 11.211L6.09001 10.501C6.40274 10.8119 6.78661 11.0418 7.20833 11.1708C7.63005 11.2998 8.07687 11.3238 8.51001 11.241V11.251Z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill-rule", "evenodd");
		builder.AddAttribute(27, "clip-rule", "evenodd");
		builder.AddAttribute(28, "d", "M9.5 1.5C9.5 2.15311 9.0826 2.70873 8.5 2.91465V3H11C12.6569 3 14 4.34315 14 6V7L15 8V10L14 11V12C14 13.6569 12.6569 15 11 15H5C3.34315 15 2 13.6569 2 12V11L1 10V8L2 7V6C2 4.34315 3.34315 3 5 3H7.5V2.91465C6.9174 2.70873 6.5 2.15311 6.5 1.5C6.5 0.671573 7.17157 0 8 0C8.82843 0 9.5 0.671573 9.5 1.5ZM5 4C3.89543 4 3 4.89543 3 6V12C3 13.1046 3.89543 14 5 14H11C12.1046 14 13 13.1046 13 12V6C13 4.89543 12.1046 4 11 4H5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
