// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoFastFood : ComponentBase
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
		builder.AddAttribute(14, "d", "M368,128h.09");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M479.55,96H388.49l8.92-35.66,38.32-13.05c8.15-2.77,13-11.43,10.65-19.71a16,16,0,0,0-20.54-10.73l-47,16a16,16,0,0,0-10.36,11.27L355.51,96H224.45c-8.61,0-16,6.62-16.43,15.23A16,16,0,0,0,224,128h2.75l1,8.66A8.3,8.3,0,0,0,236,144h0c39,0,73.66,10.9,100.12,31.52A121.9,121.9,0,0,1,371,218.07a123.4,123.4,0,0,1,10.12,29.51,7.83,7.83,0,0,0,3.29,4.88,72,72,0,0,1,26.38,86.43,7.92,7.92,0,0,0-.15,5.53A96,96,0,0,1,416,376c0,22.34-7.6,43.63-21.4,59.95a80.12,80.12,0,0,1-28.78,21.67,8,8,0,0,0-4.21,4.37,108.19,108.19,0,0,1-17.37,29.86l0,0a2.5,2.5,0,0,0,1.9,4.11h49.21a48.22,48.22,0,0,0,47.85-44.14L477.4,128H480a16,16,0,0,0,16-16.77C495.58,102.62,488.16,96,479.55,96Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M108.69,320a23.87,23.87,0,0,1,17,7l15.51,15.51a4,4,0,0,0,5.66,0L162.34,327a23.87,23.87,0,0,1,17-7H375.92a8,8,0,0,0,8.08-7.92V312a40.07,40.07,0,0,0-32-39.2c-.82-29.69-13-54.54-35.51-72C295.67,184.56,267.85,176,236,176H164c-68.22,0-114.43,38.77-116,96.8A40.07,40.07,0,0,0,16,312h0a8,8,0,0,0,8,8Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M185.94,352a8,8,0,0,0-5.66,2.34l-22.14,22.15a20,20,0,0,1-28.28,0l-22.14-22.15a8,8,0,0,0-5.66-2.34H32.66A15.93,15.93,0,0,0,16.9,365.17,65.22,65.22,0,0,0,16,376c0,30.59,21.13,55.51,47.26,56,2.43,15.12,8.31,28.78,17.16,39.47C93.51,487.28,112.54,496,134,496H266c21.46,0,40.49-8.72,53.58-24.55,8.85-10.69,14.73-24.35,17.16-39.47,26.13-.47,47.26-25.39,47.26-56a65.22,65.22,0,0,0-.9-10.83A15.93,15.93,0,0,0,367.34,352Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
