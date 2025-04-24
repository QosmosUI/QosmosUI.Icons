// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiOldMicrophone : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 27.998c-33.784 0-67.564 12.67-80.97 38.004H240v17.996h-70.574c-.563 4.866-.428 8.98-.428 14.004H240v17.996h-71.002v14.004H240v17.996h-71.002v14.004h174.004v-14.004H272v-17.996h71.002v-14.004H272V98.002h71.002c.022-4.63.077-9.796-.428-14.004H272V66.002h64.97C323.565 40.668 289.785 27.998 256 27.998zM80 162.002v17.996h22.678c-.148 4.753-.266 9.44-.326 14.004h18.002c.06-4.551.18-9.241.332-14.004h30.316v-17.996zm280.998 0v17.996h29.94a860.86 860.86 0 0 1-.254 14.004h18.013c.12-4.563.192-9.25.24-14.004H432v-17.996zm-192 17.996v18.004h174.004v-18.004zm-66.654 32c1.175 86.626 19.908 134.76 47.8 161.498 24.806 23.779 55.434 29.003 82.854 30.158v46.348h46.004v-46.377c26.698-1.218 55.672-6.572 79.361-30.262 26.772-26.771 45.324-74.691 49.658-161.365h-18.046c-4.382 83.532-22.405 126.705-44.338 148.639C320.364 385.91 288 386.002 256 386.002s-67.037-.226-93.4-25.498c-22.91-21.962-41.029-64.919-42.245-148.506zm66.654 4V283c0 39.1 37.7 59.99 78.004 62.691V215.998zm96 0v129.693c40.303-2.7 78.004-23.591 78.004-62.691v-67.002zm-144 252v16.004h270.004v-16.004z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
