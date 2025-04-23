// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiOfficeChair : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 29c-17.3 0-34.7 1.98-48.1 5.68-13.4 3.69-22 9.64-23.8 13.35-29 57.97-30.9 130.57-31 178.97h205.8c-.1-48.4-2-121-31-178.97-1.8-3.71-10.4-9.66-23.8-13.35C290.7 30.98 273.3 29 256 29zM48 167v18h48v-18zm368 0v18h48v-18zM71 204v68.8l31.2 20.8c1.6-6 4.2-11.6 7.3-16.7L89 263.2V204zm352 0v59.2l-20.5 13.7c3.1 5.1 5.7 10.7 7.3 16.7l31.2-20.8V204zm-190 41v14h46v-14zm-100.9 32c-6.2 6.9-11.9 16.4-13.2 24.5-1.5 8.7-.2 15.1 11.4 21.5h251.4c11.6-6.4 12.9-12.8 11.4-21.5-1.3-8.1-7-17.6-13.2-24.5zM247 341v32l-121.2 30.3 4.4 17.4L247 391.5V420c2.9-.6 5.9-1 9-1 3.1 0 6.1.4 9 1v-28.5l116.8 29.2 4.4-17.4L265 373v-32zm-119 96c-12.8 0-23 10.2-23 23s10.2 23 23 23 23-10.2 23-23-10.2-23-23-23zm128 0c-12.8 0-23 10.2-23 23s10.2 23 23 23 23-10.2 23-23-10.2-23-23-23zm128 0c-12.8 0-23 10.2-23 23s10.2 23 23 23 23-10.2 23-23-10.2-23-23-23z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
