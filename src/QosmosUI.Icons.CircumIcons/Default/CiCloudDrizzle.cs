// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiCloudDrizzle : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Cloud_Drizzle");
		builder.AddAttribute(15, "data-name", "Cloud Drizzle");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M17.605,16.787v1.018a.5.5,0,0,0,1,0V16.787a.516.516,0,0,0-.146-.354.5.5,0,0,0-.854.354Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M11.5,16.787v1.018a.516.516,0,0,0,.146.353.5.5,0,0,0,.854-.353V16.787a.521.521,0,0,0-.146-.354.5.5,0,0,0-.854.354Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M14.552,20.343v1.018a.5.5,0,0,0,1,0V20.343a.516.516,0,0,0-.146-.354.5.5,0,0,0-.854.354Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M8.446,20.343v1.018a.5.5,0,0,0,1,0V20.343a.521.521,0,0,0-.146-.354.5.5,0,0,0-.854.354Z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M5.393,16.787v1.018a.5.5,0,0,0,1,0V16.787a.521.521,0,0,0-.146-.354.5.5,0,0,0-.854.354Z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M16.1,14.228h-5.99A6.116,6.116,0,0,1,3.916,8.474h0A6.044,6.044,0,0,1,9.953,2.139a6.07,6.07,0,0,1,5.8,4.366,3.919,3.919,0,0,1,3.288,1.2,3.85,3.85,0,0,1,1.038,2.908A3.946,3.946,0,0,1,16.1,14.228ZM4.915,8.427a5.117,5.117,0,0,0,5.194,4.8H16.1a2.944,2.944,0,0,0,2.986-2.682,2.873,2.873,0,0,0-3.494-3l-.2.046-.25-.124a.592.592,0,0,1-.262-.377A5.061,5.061,0,0,0,9.953,3.139,5.043,5.043,0,0,0,4.915,8.427Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
