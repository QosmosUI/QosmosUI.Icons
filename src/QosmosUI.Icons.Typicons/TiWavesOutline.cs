// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiWavesOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.221 10.761c.498-.552.779-1.252.779-2 0-.801-.312-1.555-.879-2.121-.566-.567-1.32-.879-2.121-.879s-1.555.312-2.121.879c-.233.232-.546.361-.879.361-.333 0-.646-.129-.879-.362-1.366-1.366-3.185-2.118-5.121-2.118s-3.755.752-5.121 2.118c-.567.567-.879 1.321-.879 2.122 0 .748.281 1.448.779 2-.498.551-.779 1.252-.779 2s.281 1.448.779 2c-.498.551-.779 1.252-.779 2 0 .801.312 1.555.879 2.121.566.566 1.32.879 2.121.879s1.555-.312 2.121-.879c.234-.233.545-.362.878-.362.333 0 .646.129.88.363 1.367 1.365 3.185 2.117 5.121 2.117 1.937 0 3.755-.752 5.121-2.118.567-.567.879-1.32.879-2.121 0-.748-.281-1.448-.779-2 .498-.552.779-1.252.779-2s-.281-1.449-.779-2zm-1.514 6.707c-1.021 1.021-2.364 1.532-3.707 1.532-1.342 0-2.685-.511-3.707-1.532-.633-.632-1.463-.948-2.293-.948-.831 0-1.661.316-2.292.948-.196.195-.452.293-.708.293s-.512-.098-.707-.293c-.391-.391-.391-1.023 0-1.414 1.021-1.021 2.364-1.532 3.706-1.532 1.343 0 2.686.511 3.708 1.532.632.632 1.463.947 2.293.947.831 0 1.661-.315 2.293-.947.195-.195.451-.293.707-.293s.512.098.707.293c.391.39.391 1.023 0 1.414zm-13.414-9.414c1.021-1.022 2.365-1.533 3.707-1.533 1.343 0 2.685.511 3.707 1.532.632.633 1.463.948 2.293.948.831 0 1.661-.315 2.293-.947.195-.196.451-.293.707-.293s.512.098.707.293c.391.391.391 1.023 0 1.414-1.021 1.021-2.364 1.532-3.707 1.532-1.342 0-2.685-.511-3.707-1.532-.633-.632-1.463-.948-2.293-.948-.831 0-1.661.316-2.292.948-.196.195-.452.293-.708.293s-.512-.098-.707-.293c-.391-.391-.391-1.024 0-1.414zm13.414 5.414c-1.021 1.021-2.364 1.532-3.707 1.532-1.342 0-2.685-.511-3.707-1.532-.633-.632-1.463-.948-2.293-.948-.831 0-1.661.316-2.292.948-.196.195-.452.293-.708.293s-.512-.098-.707-.293c-.391-.391-.391-1.023 0-1.414 1.021-1.021 2.364-1.532 3.706-1.532 1.343 0 2.686.511 3.708 1.532.632.632 1.463.947 2.293.947.831 0 1.661-.315 2.293-.947.195-.195.451-.293.707-.293s.512.098.707.293c.391.39.391 1.023 0 1.414z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
