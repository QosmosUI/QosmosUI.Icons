// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiPenpot : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M4.415,7.22a.755.755,0,0,0-.35.64v9.67a1.536,1.536,0,0,0,.88,1.38l5.96,2.82a2.618,2.618,0,0,0,2.19,0l5.96-2.82a1.536,1.536,0,0,0,.88-1.38V7.86a.742.742,0,0,0-.36-.64l-2.23-1.15v-1a.98.98,0,0,0-.15-.52l-1.33-2.16a.749.749,0,0,0-1.28,0L13.3,4.5l-.66-1.07A.755.755,0,0,0,12,3.08a.791.791,0,0,0-.64.36l-.65,1.06L9.4,2.39a.749.749,0,0,0-1.28,0L6.805,4.55a.98.98,0,0,0-.15.52v1Zm12.93-.01.7.35-.7.33Zm-2.44-3.43h.64l.5.81h-1.64Zm1.44,1.81V8.36l-.61.29V5.59Zm-2.23,0h.62V9.12l-.62.3ZM8.445,3.78h.64l.5.81H7.945Zm1.44,1.81V9.41l-.61-.29V5.59Zm-2.23,0h.62V8.65l-.62-.29Zm-1,1.62v.68l-.7-.33ZM5.365,18a.52.52,0,0,1-.3-.47V8.24l6.43,3.04v9.59Zm6.13-7.83-.61-.29V6.64h.61Zm-.32-4.53.51-.82h.62l.51.82Zm1.94,1V9.89l-.62.29V6.64ZM12.5,20.88V11.29l6.44-3.05v9.29a.512.512,0,0,1-.31.47Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
