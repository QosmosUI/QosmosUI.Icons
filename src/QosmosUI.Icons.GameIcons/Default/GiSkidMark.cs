// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSkidMark : ComponentBase
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
		builder.AddAttribute(14, "d", "M495.063 19.938L453.125 35.03l26.844 26.876 15.092-41.968zM433.688 42.03l-64.063 23.032 27.5 14.782 11.094 5.937-8.908 8.907-11.625 11.626 22.375 22.406 11.188-11.19 8.875-8.874 5.938 11.063 13.843 25.718 23.063-64.125-39.283-39.282zm-87.72 31.564L247.532 109l78.376 42.094 11.063 5.937-8.908 8.907-11.625 11.625 22.375 22.407L350 188.78l8.875-8.905 5.97 11.094 41.124 76.5 35.436-98.408-15.844-29.437-8.906 8.906-6.625 6.626-6.592-6.625-35.594-35.593-6.625-6.593 6.624-6.625 9.344-9.345-31.22-16.78zM223.876 117.53l-25.375 9.126 47.063 47.063-53.75 31.03 52.312 28.094 11.063 5.97-8.875 8.874-11.688 11.687L257 281.75l11.22-11.22 8.874-8.874 5.97 11.063 27.123 50.436 31.063-53.78 47.094 47.093 9.125-25.345-43.158-80.25-8.906 8.906-6.594 6.626-6.625-6.625-35.593-35.593-6.594-6.593 6.594-6.625 9.375-9.376-82.095-44.063zm-51.125 98.22l-88.156 50.906 81.812 43.906 11.063 5.97-8.876 8.874-11.656 11.656 22.375 22.407 11.187-11.19 8.875-8.905 5.97 11.063 42.936 79.875 50.907-88.125-26.625-49.563-8.937 8.938-6.594 6.593-6.592-6.594-35.625-35.593-6.594-6.626 6.593-6.594 9.375-9.375-51.438-27.625zM65.562 277.656L19.844 304.03v54.47l62.312 33.47 11.094 5.936-8.906 8.875-11.656 11.658 22.374 22.375 11.188-11.157 8.906-8.906 5.938 11.063 33.97 63.156h55.874l26.375-45.626-42.5-78.97-8.907 8.907-6.594 6.595-6.625-6.594-35.593-35.592-6.594-6.625 6.594-6.594 9.375-9.376-80.907-43.438zm-45.718 102.03V494.97h114l-23.25-43.22-8.906 8.906-6.626 6.594-6.593-6.594-35.595-35.594-6.625-6.593 6.625-6.626 9.375-9.375-42.406-22.783z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
