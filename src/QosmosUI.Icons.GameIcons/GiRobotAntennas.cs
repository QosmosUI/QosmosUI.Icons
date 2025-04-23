// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiRobotAntennas : ComponentBase
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
		builder.AddAttribute(14, "d", "M81 21.499c-12.81 0-23 10.192-23 23.002 0 12.81 10.19 23 23 23s23.002-10.19 23.002-23S93.81 21.499 81 21.499zm350 0c-12.81 0-23.002 10.192-23.002 23.002 0 12.81 10.192 23 23.002 23 12.81 0 23-10.19 23-23s-10.19-23.002-23-23.002zM110.18 73.212a41.25 41.25 0 0 1-15.11 9.781l28.666 45.867 14.983-9.988zm291.64 0l-28.539 45.66 14.983 9.988 28.666-45.867a41.25 41.25 0 0 1-15.11-9.781zm-242.966 53.87l-36.143 24.095 6.652 19.955c9.215-12.422 23.339-21.987 39.614-28.912 1.172-.5 2.37-.973 3.568-1.448zm194.292 0l-13.69 13.69c1.197.475 2.395.949 3.567 1.448 16.275 6.925 30.399 16.49 39.614 28.912l6.652-19.955zM256 144.5c-29 0-58.021 4.939-79.977 14.281-21.898 9.319-35.908 22.38-39.164 38.364L106.28 426.5h299.442l-30.58-229.355c-3.256-15.984-17.266-29.045-39.164-38.364C314.02 149.44 285 144.501 256 144.501zm-64 58c31.373 0 57 25.627 57 57s-25.627 57-57 57-57-25.627-57-57 25.627-57 57-57zm128 0c31.373 0 57 25.627 57 57s-25.627 57-57 57-57-25.627-57-57 25.627-57 57-57zm-128.549 16.023c-22.754 0-41.547 18.366-41.547 40.977 0 22.611 18.793 40.977 41.547 40.977 22.754 0 41.549-18.366 41.549-40.977 0-22.611-18.795-40.977-41.549-40.977zm128 0c-22.754 0-41.547 18.366-41.547 40.977 0 22.611 18.793 40.977 41.547 40.977 22.754 0 41.549-18.366 41.549-40.977 0-22.611-18.795-40.977-41.549-40.977zm-128 17.998c13.198 0 23.549 10.269 23.549 22.979 0 12.71-10.35 22.978-23.549 22.978-13.198 0-23.549-10.268-23.549-22.978s10.351-22.979 23.55-22.979zm128 0c13.198 0 23.549 10.269 23.549 22.979 0 12.71-10.35 22.978-23.549 22.978-13.198 0-23.549-10.268-23.549-22.978s10.351-22.979 23.55-22.979zM208 330.501h96v18h-96zm-16 32h128v18H192zm-16 32h160v18H176zm-103 50v46h46v-46zm64 0v46h46v-46zm64 0v46h46v-46zm64 0v46h46v-46zm64 0v46h46v-46zm64 0v46h46v-46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
